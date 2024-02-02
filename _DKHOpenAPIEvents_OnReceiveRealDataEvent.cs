using System;

namespace AxKHOpenAPILib
{
	// Token: 0x02000006 RID: 6
	public class _DKHOpenAPIEvents_OnReceiveRealDataEvent
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000313C File Offset: 0x0000133C
		public _DKHOpenAPIEvents_OnReceiveRealDataEvent(string sRealKey, string sRealType, string sRealData)
		{
			this.sRealKey = sRealKey;
			this.sRealType = sRealType;
			this.sRealData = sRealData;
		}

		// Token: 0x04000016 RID: 22
		public string sRealKey;

		// Token: 0x04000017 RID: 23
		public string sRealType;

		// Token: 0x04000018 RID: 24
		public string sRealData;
	}
}
