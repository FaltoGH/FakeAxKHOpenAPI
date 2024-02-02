using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxKHOpenAPILib
{
    /// <summary>
    /// Provides fake AxKHOpenAPI for test.
    /// </summary>
    public class FakeAxKHOpenAPI:AxKHOpenAPI
    {
        
        public override int CommConnect()
        {
            RaiseOnOnEventConnect(this, new _DKHOpenAPIEvents_OnEventConnectEvent(0));
            return 0;
        }

        public override string GetMasterCodeName(string sTrCode)
        {
            return $"N{sTrCode}";
        }

        public override string GetCodeListByMarket(string sMarket)
        {
            return "000020;005930;005935";
        }

        public override int GetConnectState()
        {
            return 1;
        }

        public override string GetLoginInfo(string sTag)
        {
            switch (sTag)
            {
                case "ACCOUNT_CNT":
                    return "3";
                case "ACCLIST":
                case "ACCNO":
                    return "1234567890;9876543210;1324354657";
                case "USER_ID":
                    return "{USER_ID}";
                case "USER_NAME":
                    return "{USER_NAME}";
                case "GetServerGubun":
                    return "1";
                case "ACCTLIST_DETAIL":
                    return "1234567890,홍길동,위탁종합;9876543210,홍길동,위탁종합;1324354657,홍길동,선물옵션";
            }
            return sTag;
        }

        readonly List<KeyValuePair<string, string>> inputValues = new List<KeyValuePair<string, string>>();

        public override void SetInputValue(string sID, string sValue)
        {
            inputValues.Add(new KeyValuePair<string, string>(sID, sValue));
        }

        public override int CommRqData(string sRQName, string sTrCode, int nPrevNext, string sScreenNo)
        {
            RaiseOnOnReceiveTrData(this, new _DKHOpenAPIEvents_OnReceiveTrDataEvent(sScreenNo, sRQName, sTrCode, null, "0", 0, null, null, null));
            return 0;
        }

        public override int GetRepeatCnt(string sTrCode, string sRecordName)
        {
            switch (sTrCode.ToUpper())
            {
                case "OPT10081":
                    return 600;
            }
            return 0;
        }

        public override string GetCommData(string strTrCode, string strRecordName, int nIndex, string strItemName)
        {
            switch (strTrCode.ToUpper())
            {
                case "OPT10081":
                    switch (strItemName)
                    {
                        case "거래대금":
                            return "4000000";
                        case "일자":
                            return nIndex.ToString();
                        case "거래량":
                        case "현재가":
                        case "시가":
                        case "고가":
                        case "저가":
                            return "2000";
                    }
                    break;
                case "OPW00004":
                    switch (strItemName)
                    {
                        case "D+2추정예수금":
                        case "추정예탁자산":
                        case "예수금":
                        case "유가잔고평가액":
                            return "2000";
                    }
                    break;
            }
            return strItemName;
        }

        public override string KOA_Functions(string sFunctionName, string sParam)
        {
            switch (sFunctionName)
            {
                case "GetStockMarketKind":
                    return "0";
            }
            return sFunctionName;
        }

    }
}
