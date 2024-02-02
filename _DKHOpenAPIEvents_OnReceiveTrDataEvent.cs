using System;

namespace AxKHOpenAPILib
{
	// Token: 0x02000004 RID: 4
	public class _DKHOpenAPIEvents_OnReceiveTrDataEvent
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000030E4 File Offset: 0x000012E4
		public _DKHOpenAPIEvents_OnReceiveTrDataEvent(string sScrNo, string sRQName, string sTrCode, string sRecordName, string sPrevNext, int nDataLength, string sErrorCode, string sMessage, string sSplmMsg)
		{
			this.sScrNo = sScrNo;
			this.sRQName = sRQName;
			this.sTrCode = sTrCode;
			this.sRecordName = sRecordName;
			this.sPrevNext = sPrevNext;
			this.nDataLength = nDataLength;
			this.sErrorCode = sErrorCode;
			this.sMessage = sMessage;
			this.sSplmMsg = sSplmMsg;
		}

		// Token: 0x0400000D RID: 13
		public string sScrNo;

		// Token: 0x0400000E RID: 14
		public string sRQName;

		// Token: 0x0400000F RID: 15
		public string sTrCode;

		// Token: 0x04000010 RID: 16
		public string sRecordName;

		// Token: 0x04000011 RID: 17
		public string sPrevNext;

		// Token: 0x04000012 RID: 18
		public int nDataLength;

		// Token: 0x04000013 RID: 19
		public string sErrorCode;

		// Token: 0x04000014 RID: 20
		public string sMessage;

		// Token: 0x04000015 RID: 21
		public string sSplmMsg;
	}
}
