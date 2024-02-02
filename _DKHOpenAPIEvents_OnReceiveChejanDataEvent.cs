using System;

namespace AxKHOpenAPILib
{
	// Token: 0x0200000A RID: 10
	public class _DKHOpenAPIEvents_OnReceiveChejanDataEvent
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000317E File Offset: 0x0000137E
		public _DKHOpenAPIEvents_OnReceiveChejanDataEvent(string sGubun, int nItemCnt, string sFIdList)
		{
			this.sGubun = sGubun;
			this.nItemCnt = nItemCnt;
			this.sFIdList = sFIdList;
		}

        /// <summary>
        /// 체결구분. 접수와 체결시 '0'값, 국내주식 잔고변경은 '1'값, 파생잔고변경은 '4'
        /// </summary>
        // Token: 0x0400001D RID: 29
        public string sGubun;

		// Token: 0x0400001E RID: 30
		public int nItemCnt;

		// Token: 0x0400001F RID: 31
		public string sFIdList;
	}
}
