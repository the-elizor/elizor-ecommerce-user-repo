// <copyright file="ILoginRepository.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.entities.checkUser;
using elizor.ecommerce.user.entities.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.contracts.Repositories
{
    public interface ILoginRepository
    {
        CheckUserResponse CheckUserExists(CheckUserRequest request);
    }
}
