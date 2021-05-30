﻿// <copyright file="ServiceResponseMapper.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.shared.Contracts;
using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.shared.Mappers
{
    public class ServiceResponseMapper : IMapper<Object, ResponseBase>
    {
        /// <summary>
        /// Map success response
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ResponseBase Map(object input)
        {
            return new ResponseBase
            {
                Result = input,
                IsSuccess = true,
                Error = new ResponseMessage { Code = "", Message = "" }

            };
        }
    }
}
