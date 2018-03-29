namespace botiloid.gameBot
{
    interface IBotControl
    {
        string moveTo(POIData pt);
        void release();
    }
}
