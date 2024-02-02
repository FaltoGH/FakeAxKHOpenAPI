using System;

namespace AxKHOpenAPILib
{
	// Token: 0x02000008 RID: 8
	public class _DKHOpenAPIEvents_OnReceiveMsgEvent
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00003159 File Offset: 0x00001359
		public _DKHOpenAPIEvents_OnReceiveMsgEvent(string sScrNo, string sRQName, string sTrCode, string sMsg)
		{
			this.sScrNo = sScrNo;
			this.sRQName = sRQName;
			this.sTrCode = sTrCode;
			this.sMsg = sMsg;
		}

		// Token: 0x04000019 RID: 25
		public string sScrNo;

		// Token: 0x0400001A RID: 26
		public string sRQName;

		// Token: 0x0400001B RID: 27
		public string sTrCode;

		// Token: 0x0400001C RID: 28
		public string sMsg;
	}
}
