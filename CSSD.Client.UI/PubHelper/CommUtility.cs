using CSSD.Server.DataModel.ManagerBenchModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ControlLib = DevComponents.DotNetBar;

namespace CSSD.Client.UI.PubHelper
{
    public class CommUtility
    {
        #region 助记码生成
        /// <summary>
        /// 返回汉字字符串的拼音的首字母
        /// </summary>
        /// <param name="chinesestr">要转换的字符串</param>
        /// <returns></returns>
        public static string GetSpellCode(string chinesestr)
        {
            byte[] zw = new byte[2];
            long chinesestr_int;
            string charstr, chinastr = "", capstr = "";
            for (int i = 0; i <= chinesestr.Length - 1; i++)
            {
                charstr = chinesestr.Substring(i, 1).ToString();
                zw = System.Text.Encoding.Default.GetBytes(charstr);
                // 得到汉字符的字节数组 
                if (zw.Length == 2)
                {
                    int i1 = (short)(zw[0]);
                    int i2 = (short)(zw[1]);
                    chinesestr_int = i1 * 256 + i2;


                    if ((chinesestr_int >= 45217) && (chinesestr_int <= 45252))
                    {
                        chinastr = "A";
                    }
                    else if ((chinesestr_int >= 45253) && (chinesestr_int <= 45760))
                    {
                        chinastr = "B";
                    }
                    else if ((chinesestr_int >= 45761) && (chinesestr_int <= 46317))
                    {
                        chinastr = "C";

                    }
                    else if ((chinesestr_int >= 46318) && (chinesestr_int <= 46825))
                    {
                        chinastr = "D";
                    }
                    else if ((chinesestr_int >= 46826) && (chinesestr_int <= 47009))
                    {
                        chinastr = "E";
                    }
                    else if ((chinesestr_int >= 47010) && (chinesestr_int <= 47296))
                    {
                        chinastr = "F";
                    }
                    else if ((chinesestr_int >= 47297) && (chinesestr_int <= 47613))
                    {
                        chinastr = "G";
                    }
                    else if ((chinesestr_int >= 47614) && (chinesestr_int <= 48118))
                    {

                        chinastr = "H";
                    }

                    else if ((chinesestr_int >= 48119) && (chinesestr_int <= 49061))
                    {
                        chinastr = "J";
                    }
                    else if ((chinesestr_int >= 49062) && (chinesestr_int <= 49323))
                    {
                        chinastr = "K";
                    }
                    else if ((chinesestr_int >= 49324) && (chinesestr_int <= 49895))
                    {
                        chinastr = "L";
                    }
                    else if ((chinesestr_int >= 49896) && (chinesestr_int <= 50370))
                    {
                        chinastr = "M";
                    }

                    else if ((chinesestr_int >= 50371) && (chinesestr_int <= 50613))
                    {
                        chinastr = "N";

                    }
                    else if ((chinesestr_int >= 50614) && (chinesestr_int <= 50621))
                    {
                        chinastr = "O";
                    }
                    else if ((chinesestr_int >= 50622) && (chinesestr_int <= 50905))
                    {
                        chinastr = "P";

                    }
                    else if ((chinesestr_int >= 50906) && (chinesestr_int <= 51386))
                    {
                        chinastr = "Q";

                    }

                    else if ((chinesestr_int >= 51387) && (chinesestr_int <= 51445))
                    {
                        chinastr = "R";
                    }
                    else if ((chinesestr_int >= 51446) && (chinesestr_int <= 52217))
                    {
                        chinastr = "S";
                    }
                    else if ((chinesestr_int >= 52218) && (chinesestr_int <= 52697))
                    {
                        chinastr = "T";
                    }
                    else if ((chinesestr_int >= 52698) && (chinesestr_int <= 52979))
                    {
                        chinastr = "W";
                    }
                    else if ((chinesestr_int >= 52980) && (chinesestr_int <= 53640))
                    {
                        chinastr = "X";
                    }
                    else if ((chinesestr_int >= 53689) && (chinesestr_int <= 54480))
                    {
                        chinastr = "Y";
                    }
                    else if ((chinesestr_int >= 54481) && (chinesestr_int <= 55289))
                    {
                        chinastr = "Z";
                    }

                }
                else
                {
                    capstr += chinesestr[i] + "";
                    continue;
                }

                capstr = capstr + chinastr;
            }
            return capstr;
        }
        ///// <summary>
        ///// 助记码生成
        ///// </summary>
        ///// <param name="text">要生成助记码的文本</param>
        ///// <param name="spellType">助记码类型(0:拼音,1:五笔,默认是拼音)</param>
        ///// <returns></returns>
        //public static string GetSpellCode(string text, int spellType)
        //{
        //    string _strInput = "";
        //    if (spellType != 0)
        //    {
        //        //自定义助记码（五笔编码）
        //        _strInput = new TextEncoding().GetEncoding(text.Trim(), TextEncoding.EncodingType.WBCode);
        //    }
        //    else
        //    {
        //        //自定义助记码（拼音编码）
        //        _strInput = new TextEncoding().GetEncoding(text.Trim(), TextEncoding.EncodingType.Spelling);
        //    }
        //    ////判断长度是否超过10，超过截断
        //    //if (_strInput.Length > 10)
        //    //{
        //    //    _strInput = _strInput.Substring(0, 10);
        //    //}

        //    return _strInput;
        //}
        #endregion

        #region 清空控件
        /// <summary>
        /// 清空控件
        /// </summary>
        /// <param name="controls">控件集</param>
        public static void ClearControl(params Control[] controls)
        {
            try
            {
                foreach (Control control in controls)
                {
                    //if (!typeof(ControlLib.IControlBase).IsInstanceOfType(control))
                    //{
                    //    continue;
                    //}
                    if (control.GetType() == typeof(ControlLib.Controls.TextBoxX) || control.GetType() == typeof(TextBox) ||
                        control.GetType() == typeof(ControlLib.LabelX) || control.GetType() == typeof(Label))
                    {
                        control.Text = "";
                    }
                    else if (control.GetType() == typeof(CheckBox))
                    {
                        (control as ControlLib.Controls.CheckBoxX).Checked = false;
                    }
                    else if (control.GetType() == typeof(DataGridView))
                    {
                        (control as DataGridView).DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 设置控件状态
        /// <summary>
        /// 设置控件状态
        /// </summary>
        /// <param name="enabled">状态</param>
        /// <param name="controls">控件集</param>
        public static void SetEnabled(bool enabled, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                //如果是表格，就设置ReadOnly
                if (control.GetType() == typeof(DataGridView))
                {
                    DataGridView dataGrid = (DataGridView)control;
                    dataGrid.ReadOnly = !enabled;
                    continue;
                }

                if (control.IsHandleCreated && control.IsDisposed == false)
                    control.Enabled = enabled;
            }
        }
        #endregion

        #region 只能录入数字
        /// <summary>
        /// 只能录入数字(包含负数、小数)
        /// </summary>
        /// <param name="e">键对象</param>
        public static void OnlyEntryNumber(KeyEventArgs e)
        {
            OnlyEntryNumber(e, true, true, "");
        }

        /// <summary>
        /// 只能录入数字
        /// </summary>
        /// <param name="e">键对象</param>
        /// <param name="allowDecimals">允许小数</param>
        /// <param name="allowNegative">允许负数</param>
        /// <param name="sValue">当前控件的值</param>
        public static void OnlyEntryNumber(KeyEventArgs e, bool allowDecimals, bool allowNegative, string sValue)
        {
            if (e.KeyCode == Keys.Back ||
                    e.KeyCode == Keys.Delete ||
                    e.KeyCode == Keys.Escape ||
                    e.KeyCode == Keys.Left ||
                    e.KeyCode == Keys.Right ||
                    e.KeyCode == Keys.Up ||
                    e.KeyCode == Keys.Down ||
                    e.Alt || e.Control)
                return;

            //允许小数点
            if (e.KeyValue == 190 ||//大键盘点
                e.KeyValue == 110)//小键盘点
            {
                if (allowDecimals)
                {
                    if (sValue.IndexOf('.') < 0)
                    {
                        return;
                    }
                }
            }
            //允许负数
            if (e.KeyValue == 189 ||//大键盘减
                e.KeyValue == 109)//小键盘减
            {
                if (allowNegative)
                {
                    return;
                }
            }

            if (e.KeyValue < 48 || (e.KeyValue > 57 && e.KeyValue < 96) || e.KeyValue > 105)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 从DATATABLE中查找符合条件的数据并返回
        /// <summary>
        /// 从DATATABLE中查找符合条件的数据并返回
        /// </summary>
        /// <param name="dtsource">源TABLE</param>
        /// <param name="strCondition">过滤条件</param>
        /// <returns></returns>
        public static DataTable SelectDict(DataTable dtsource, String strCondition)
        {
            if (dtsource == null || dtsource.Rows.Count == 0) return new DataTable();

            DataRow[] Rows = dtsource.Select(strCondition); ;

            if (Rows == null || Rows.Count() == 0) return null;

            DataTable dttemp = dtsource.Clone();

            foreach (DataRow row in Rows)
            {
                dttemp.Rows.Add(row.ItemArray);
            }
            dttemp.AcceptChanges();

            return dttemp;
        }
        #endregion

        #region 读取编码规则XML
        public static string xmlStr = AppDomain.CurrentDomain.BaseDirectory + "CodingRules.xml";
        /// <summary>
        /// 获取指定节点Id的类型Value
        /// </summary>
        /// <param name="ddlId"></param>
        /// <returns></returns>
        public static string GetDefinitionDDLById(string ddlId)
        {
            string value = string.Empty;
            string name = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(xmlStr);
                string search = "Definition/DropDownList/ListItem[@Id='" + ddlId + "']";
                XmlElement xe = (XmlElement)xmlDoc.SelectSingleNode(search);
                value = xe.GetAttribute("Value");
                name = xe.GetAttribute("Name");
            }
            catch (Exception ex)
            {

            }
            return value;
        }
        /// <summary>
        /// 获取指定根节点Id的所有Value
        /// </summary>
        /// <param name="ddlId">ddl_DictType</param>
        /// <returns>结果集</returns>
        public static ArrayList GetAllDefinitionDDLById(string ddlId)
        {
            string value = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            ArrayList mylist = new ArrayList();
            try
            {
                xmlDoc.Load(xmlStr);
                string search = "Definition/DropDownList[@Id='" + ddlId + "']";
                XmlNodeList list = xmlDoc.SelectSingleNode(search).ChildNodes;

                foreach (XmlNode xn in list)
                {
                    XmlElement xe = xn as XmlElement;
                    mylist.Add(new DictionaryEntry(xe.GetAttribute("Value"), xe.GetAttribute("Name")));
                }
            }
            catch
            {
            }
            return mylist;
        }
        #endregion

        #region 读取规则编码
        /// <summary>
        /// 读取规则编码
        /// </summary>
        /// <param name="codeID">编码类型编号</param>
        /// <returns></returns>
        public static string GetCodingRules(int codeID)
        {
            CodingRulesModel codingModel = new CodingRulesModel();
            string errorString = string.Empty;
            string CodingReles = string.Empty;
            //根据主键编号获取编码信息
            DataTable dtByID = codingModel.DelayedSelectByID(out errorString, PubStaticModel.ConnectionStr, codeID);
            if (dtByID == null || dtByID.Rows.Count <= 0) return "";
            //获取编码长度
            int codeLenght = Convert.ToInt32(dtByID.Rows[0]["CodingRulesLength"]);
            //获取自增数
            int CodingRulesIncreasing = Convert.ToInt32(dtByID.Rows[0]["CodingRulesIncreasing"]);
            //获取预设值
            string CodingRulesValue = dtByID.Rows[0]["CodingRulesValue"] + "";
            //获取当前编号
            int CurrentCode = Convert.ToInt32(dtByID.Rows[0]["CurrentCode"] + "");
            //计算增加后的编码
            int SumCode = CurrentCode + CodingRulesIncreasing;
            //添加预设值到最前
            CodingReles += CodingRulesValue;
            for (int i = 0; i < codeLenght - CodingRulesValue.Length - SumCode.ToString().Length; i++)
            {
                CodingReles += 0;
            }
            CodingReles += SumCode;
            codingModel.CodingRulesID = codeID;
            codingModel.CurrentCode = SumCode;
            codingModel.DelayedUpdateCurrentCode(out errorString, PubStaticModel.ConnectionStr);
            return CodingReles;
        }
        #endregion
    }
}
