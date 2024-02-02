using System;

namespace AxKHOpenAPILib
{
	// Token: 0x02000012 RID: 18
	public class _DKHOpenAPIEvents_OnReceiveTrConditionEvent
	{
		// Token: 0x06000081 RID: 129 RVA: 0x000031DE File Offset: 0x000013DE
		public _DKHOpenAPIEvents_OnReceiveTrConditionEvent(string sScrNo, string strCodeList, string strConditionName, int nIndex, int nNext)
		{
			this.sScrNo = sScrNo;
			this.strCodeList = strCodeList;
			this.strConditionName = strConditionName;
			this.nIndex = nIndex;
			this.nNext = nNext;
		}

		// Token: 0x04000026 RID: 38
		public string sScrNo;

		// Token: 0x04000027 RID: 39
		public string strCodeList;

		// Token: 0x04000028 RID: 40
		public string strConditionName;

		// Token: 0x04000029 RID: 41
		public int nIndex;

		// Token: 0x0400002A RID: 42
		public int nNext;
	}
}
