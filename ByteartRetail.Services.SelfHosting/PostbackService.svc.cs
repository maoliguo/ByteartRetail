﻿ 

// ******************************************************
// DO NOT CHANGE THE CONTENT OF THIS FILE
// This file was generated by the T4 engine and the 
// contents of this source code will be changed after
// the custom tool was run.
// ******************************************************
using System;
using System.Collections.Generic;
using System.ServiceModel;
using ByteartRetail.Application;
using ByteartRetail.DataObjects;
using ByteartRetail.ServiceContracts;
using ByteartRetail.Infrastructure;

namespace ByteartRetail.Services.SelfHosting
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
	public class PostbackService : IPostbackService
	{
		private readonly IPostbackService postbackServiceImpl = ServiceLocator.Instance.GetService<IPostbackService>();
				public PostbackDataObject GetPostback()
		{
			try
			{
				return postbackServiceImpl.GetPostback();
			}
			catch(Exception ex)
			{
				throw new FaultException<FaultData>(FaultData.CreateFromException(ex), FaultData.CreateFaultReason(ex));
			}
		}
		public void Dispose() { postbackServiceImpl.Dispose(); }
	}
}


