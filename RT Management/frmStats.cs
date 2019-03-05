using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace RT_Management
{
    public partial class frmStats : Form
    {
        public frmStats()
        {
            InitializeComponent();
        }

        private void FrmStats_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData() 
        {
            int incompleto = GetStatus(1);
            int proceso = GetStatus(0);
            int procedente = GetStatus(2);
            int improcedente = GetStatus(3);
            int totales = incompleto + proceso + procedente + improcedente;
            Representacion(zedGrafico, incompleto, proceso, procedente, improcedente, totales);
        }

        private int GetStatus(int estado)
        {
            int valor = 0;
            conexionBD db = new conexionBD();
            String consulta = "SELECT status FROM deducibles WHERE status=" + estado.ToString();
            db.Conectar();
            valor = db.BuscarNum(consulta);
            return valor;
        }

        private void Representacion(ZedGraphControl zedControl, int incompleto, int proceso, int procedente, int improcedente, int totales) 
        {
            GraphPane grafico = zedGrafico.GraphPane;
            double[] values = {incompleto, proceso, procedente, improcedente};
            string[] labels = {"Incompleto", "En proceso", "Procedente", "No procedente"};
            Color[] colors = { Color.Orange, Color.Yellow, Color.Green, Color.Red };

            grafico.Title.Text = "Expedientes recibidos";

            grafico.Fill = new Fill(Color.White, Color.Gray, 45.0f);
            grafico.Chart.Fill.Type = FillType.None;

            grafico.Legend.Position = LegendPos.Float;
            grafico.Legend.Location = new Location(0.95f, 0.15f, CoordType.PaneFraction, AlignH.Right, AlignV.Top);
            grafico.Legend.FontSpec.Size = 10f;
            grafico.Legend.IsHStack = false;
            grafico.Legend.IsVisible = false;

            PieItem[] slices = new PieItem[values.Length];
            slices = grafico.AddPieSlices(values, labels);

            ((PieItem)slices[0]).Fill.Color = Color.Orange;
            ((PieItem)slices[1]).Fill.Color = Color.Yellow;
            ((PieItem)slices[2]).Fill.Color = Color.Green;
            ((PieItem)slices[3]).Fill.Color = Color.DarkRed;
 

            ((PieItem)slices[0]).LabelType = PieLabelType.Name_Value_Percent;
            ((PieItem)slices[1]).LabelType = PieLabelType.Name_Value_Percent;
            ((PieItem)slices[2]).LabelType = PieLabelType.Name_Value_Percent;
            ((PieItem)slices[3]).LabelType = PieLabelType.Name_Value_Percent;                       

            CurveList curves = grafico.CurveList;
            double total = 0;
            for (int x = 0; x < curves.Count; x++) 
            {
                total += ((PieItem)curves[x]).Value;
            }

            TextObj text = new TextObj("Expedientes totales: " + total.ToString(), 0.12f, 0.95f, CoordType.XChartFractionYPaneFraction);
            text.Location.AlignH = AlignH.Center;
            text.Location.AlignV = AlignV.Bottom;
            text.FontSpec.Border.IsVisible = false;
            text.FontSpec.Fill = new Fill(Color.White, Color.Gray, 75.0f);
            grafico.GraphObjList.Add(text);

            zedGrafico.AxisChange();
            zedGrafico.Invalidate();
        }

    }
}
