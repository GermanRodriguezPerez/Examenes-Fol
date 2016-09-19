using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*using Mecof.Infrastructure;
using Mecof.Infrastructure.Logging.Loggers;
using Mecof.Infrastructure.Logging.Managers;
using Mecof.Infrastructure.Configuration;*/

namespace Examenes
{
    public partial class Principal_Vista : Form
    {

        //private ILogger logger = ServiceLocator.Instance.GetInstance<ILogManager>().GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Principal_Vista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AñadirPregunta_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataSet Preguntas = default(DataSet);
           

            SqlConnection con = default(SqlConnection);
            string connetionString = null;
            string query = null;


            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["Examenes.Properties.Settings.p1ConnectionString"].ConnectionString;
                        //connetionString = "Data Source=(localdb)\\V11.0;Initial Catalog=Examenes;Integrated Security = true;AttachDBFilename=|DataDirectory|\\Examenes.mdf";
            //connetionString = "Data Source=(LocalDB)\v11.0;Initial Catalog=Examenes;Integrated Security=True"

            try
            {
                con = new SqlConnection(connetionString);
                con.Open();


                query = "select * from Preguntas";
                cmd = new SqlCommand(query, con);
                adapter = new SqlDataAdapter(cmd);
                Preguntas = new DataSet();
                adapter.Fill(Preguntas);
                this.Resultados.DataSource = Preguntas.Tables[0];
                this.Resultados.AutoResizeColumns();
               // this.logger.Info("Preguntas logger");



                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {
                //this.logger.Info("Fill Combo Box Failed. Exception:" + ex.ToString());
                

                MessageBox.Show("ha habido un error: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }
    }
    }

