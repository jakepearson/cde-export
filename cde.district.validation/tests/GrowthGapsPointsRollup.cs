﻿using cde.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cde.district.validation.tests
{
	public class GrowthGapsPointsRollup : BaseTest
	{
		public override void Test(Row row, List<string> errors)
		{
			AssertSum(row, "RDPF_1YR_GG_PTS_EARN_READ", new[] { "RDPF_1YR_GG_BPA_PTS_EARN_READ", "RDPF_1YR_GG_ELL_PTS_EARN_READ", "RDPF_1YR_GG_DIS_PTS_EARN_READ", "RDPF_1YR_GG_MIN_PTS_EARN_READ", "RDPF_1YR_GG_FRL_PTS_EARN_READ" }, errors);
			AssertSum(row, "RDPF_1YR_GG_PTS_ELIG_READ", new[] { "RDPF_1YR_GG_BPA_PTS_ELIG_READ", "RDPF_1YR_GG_ELL_PTS_ELIG_READ", "RDPF_1YR_GG_DIS_PTS_ELIG_READ", "RDPF_1YR_GG_MIN_PTS_ELIG_READ", "RDPF_1YR_GG_FRL_PTS_ELIG_READ" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_EARN_READ", new[] { "RDPF_3YR_GG_BPA_PTS_EARN_READ", "RDPF_3YR_GG_ELL_PTS_EARN_READ", "RDPF_3YR_GG_DIS_PTS_EARN_READ", "RDPF_3YR_GG_MIN_PTS_EARN_READ", "RDPF_3YR_GG_FRL_PTS_EARN_READ" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_ELIG_READ", new[] { "RDPF_3YR_GG_BPA_PTS_EARN_READ", "RDPF_3YR_GG_ELL_PTS_EARN_READ", "RDPF_3YR_GG_DIS_PTS_EARN_READ", "RDPF_3YR_GG_MIN_PTS_EARN_READ", "RDPF_3YR_GG_FRL_PTS_EARN_READ" }, errors);

			AssertSum(row, "RDPF_3YR_GG_PTS_EARN_MATH", new[] { "RDPF_1YR_GG_BPA_PTS_EARN_MATH", "RDPF_1YR_GG_ELL_PTS_EARN_MATH", "RDPF_1YR_GG_DIS_PTS_EARN_MATH", "RDPF_1YR_GG_MIN_PTS_EARN_MATH", "RDPF_1YR_GG_FRL_PTS_EARN_MATH" }, errors);
			AssertSum(row, "RDPF_1YR_GG_PTS_ELIG_MATH", new[] { "RDPF_1YR_GG_BPA_PTS_ELIG_MATH", "RDPF_1YR_GG_ELL_PTS_ELIG_MATH", "RDPF_1YR_GG_DIS_PTS_ELIG_MATH", "RDPF_1YR_GG_MIN_PTS_ELIG_MATH", "RDPF_1YR_GG_FRL_PTS_ELIG_MATH" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_EARN_MATH", new[] { "RDPF_3YR_GG_BPA_PTS_EARN_MATH", "RDPF_3YR_GG_ELL_PTS_EARN_MATH", "RDPF_3YR_GG_DIS_PTS_EARN_MATH", "RDPF_3YR_GG_MIN_PTS_EARN_MATH", "RDPF_3YR_GG_FRL_PTS_EARN_MATH" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_ELIG_MATH", new[] { "RDPF_3YR_GG_BPA_PTS_ELIG_MATH", "RDPF_3YR_GG_ELL_PTS_ELIG_MATH", "RDPF_3YR_GG_DIS_PTS_ELIG_MATH", "RDPF_3YR_GG_MIN_PTS_ELIG_MATH", "RDPF_3YR_GG_FRL_PTS_ELIG_MATH" }, errors);

			AssertSum(row, "RDPF_1YR_GG_PTS_EARN_WRITE", new[] { "RDPF_1YR_GG_BPA_PTS_EARN_WRITE", "RDPF_1YR_GG_ELL_PTS_EARN_WRITE", "RDPF_1YR_GG_DIS_PTS_EARN_WRITE", "RDPF_1YR_GG_MIN_PTS_EARN_WRITE", "RDPF_1YR_GG_FRL_PTS_EARN_WRITE" }, errors);
			AssertSum(row, "RDPF_1YR_GG_PTS_ELIG_WRITE", new[] { "RDPF_1YR_GG_BPA_PTS_ELIG_WRITE", "RDPF_1YR_GG_ELL_PTS_ELIG_WRITE", "RDPF_1YR_GG_DIS_PTS_ELIG_WRITE", "RDPF_1YR_GG_MIN_PTS_ELIG_WRITE", "RDPF_1YR_GG_FRL_PTS_ELIG_WRITE" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_EARN_WRITE", new[] { "RDPF_3YR_GG_BPA_PTS_EARN_WRITE", "RDPF_3YR_GG_ELL_PTS_EARN_WRITE", "RDPF_3YR_GG_DIS_PTS_EARN_WRITE", "RDPF_3YR_GG_MIN_PTS_EARN_WRITE", "RDPF_3YR_GG_FRL_PTS_EARN_WRITE" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_ELIG_WRITE", new[] { "RDPF_3YR_GG_BPA_PTS_ELIG_WRITE", "RDPF_3YR_GG_ELL_PTS_ELIG_WRITE", "RDPF_3YR_GG_DIS_PTS_ELIG_WRITE", "RDPF_3YR_GG_MIN_PTS_ELIG_WRITE", "RDPF_3YR_GG_FRL_PTS_ELIG_WRITE" }, errors);

			AssertSum(row, "RDPF_1YR_GG_PTS_EARN_TTL", new[] { "RDPF_1YR_GG_PTS_EARN_READ", "RDPF_1YR_GG_PTS_EARN_MATH", "RDPF_1YR_GG_PTS_EARN_WRITE" }, errors);
			AssertSum(row, "RDPF_1YR_GG_PTS_ELIG_TTL", new[] { "RDPF_1YR_GG_PTS_ELIG_READ", "RDPF_1YR_GG_PTS_ELIG_MATH", "RDPF_1YR_GG_PTS_ELIG_WRITE" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_EARN_TTL", new[] { "RDPF_3YR_GG_PTS_EARN_READ", "RDPF_3YR_GG_PTS_EARN_MATH", "RDPF_3YR_GG_PTS_EARN_WRITE" }, errors);
			AssertSum(row, "RDPF_3YR_GG_PTS_ELIG_TTL", new[] { "RDPF_3YR_GG_PTS_ELIG_READ", "RDPF_3YR_GG_PTS_ELIG_MATH", "RDPF_3YR_GG_PTS_ELIG_WRITE" }, errors);
		}
	}
}
