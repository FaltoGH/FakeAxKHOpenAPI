using System;

namespace AxKHOpenAPILib
{
	// Token: 0x02000010 RID: 16
	public class _DKHOpenAPIEvents_OnReceiveRealConditionEvent
	{
		// Token: 0x0600007C RID: 124 RVA: 0x000031B9 File Offset: 0x000013B9
		public _DKHOpenAPIEvents_OnReceiveRealConditionEvent(string sTrCode, string strType, string strConditionName, string strConditionIndex)
		{
			this.sTrCode = sTrCode;
			this.strType = strType;
			this.strConditionName = strConditionName;
			this.strConditionIndex = strConditionIndex;
		}

		// Token: 0x04000022 RID: 34
		public string sTrCode;

		// Token: 0x04000023 RID: 35
		public string strType;

		// Token: 0x04000024 RID: 36
		public string strConditionName;

		// Token: 0x04000025 RID: 37
		public string strConditionIndex;
	}
}
