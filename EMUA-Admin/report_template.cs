using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMUA_Admin
{
    class report_template
    {
        public static String ID_APP_NAME = "<APP_NAME>";
        
        public static String ID_EMPLOY_FULL_NAME = "<EMP_FULL_NAME>";
        public static String ID_EMPLOY_FRIST_NAME = "<EMP_FIRST_NAME>";
        public static String ID_EMPLOY_SECOND_NAME = "<EMP_SECOND_NAME>";
        public static String ID_EMPLOY_THIRD_NAME = "<EMP_THIRD_NAME>";
        
        public static String ID_EMPLOY_TIME_DOWN = "<EMP_TIME_DOWN>";
        public static String ID_EMPLOY_TIME_EXTRA = "<EMP_TIME_EXTRA>";
        public static String ID_EMPLOY_TIME_DOWN_COUNT = "<EMP_TIME_DOWN_COUNT>";
        public static String ID_EMPLOY_TIME_EXTRA_COUNT = "<EMP_TIME_EXTRA_COUNT>";
        
        public static String ID_EMPLOY_TOTAL_SAL = "<EMP_SAL>";

        public static String ID_EMPLOY_NOTES = "<EMP_NOTES>";

        public static String createReport(String template, String fname, String sname, String tname, String notes,
                float time_down, float time_extra, int time_down_count, int time_extra_count, float sal)
        {
            String str = template;

            str = str.Replace(ID_APP_NAME, "[E.M.U.A]");
            str = str.Replace(ID_EMPLOY_FULL_NAME, fname + " " + sname + " " + tname);
            str = str.Replace(ID_EMPLOY_FRIST_NAME, fname);
            str = str.Replace(ID_EMPLOY_SECOND_NAME, sname);
            str = str.Replace(ID_EMPLOY_THIRD_NAME, tname);

            str = str.Replace(ID_EMPLOY_TIME_DOWN, Convert.ToString(time_down));
            str = str.Replace(ID_EMPLOY_TIME_EXTRA, Convert.ToString(time_extra));
            str = str.Replace(ID_EMPLOY_TIME_DOWN_COUNT, Convert.ToString(time_down_count));
            str = str.Replace(ID_EMPLOY_TIME_EXTRA_COUNT, Convert.ToString(time_extra_count));

            str = str.Replace(ID_EMPLOY_NOTES, (notes));

            str = str.Replace(ID_EMPLOY_TOTAL_SAL, Convert.ToString(sal));
            return str;
        }

    }
}
