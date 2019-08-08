﻿namespace AspNetCoreSteeltoe.Interface
{
    public interface IOPLDQueryService
    {
        string GetOPLDPackageTrackingNumber();
        string[] GetMultipleTrackingNumber(int count);
    }
}
