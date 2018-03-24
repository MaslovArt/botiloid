namespace botiloid
{
    interface IBotControl
    {
        string moveTo(POIData pt);
        void release();
    }
}
