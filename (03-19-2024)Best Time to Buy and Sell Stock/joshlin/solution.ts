function maxProfit(prices: number[]): number {
    // time: O(n), space: O(1)
    if (prices.length < 2) return 0;
    let max_profit = 0;
    let min_stock = prices[0];
    for (const price of prices) {
        const profit = price - min_stock;
        max_profit = profit > max_profit ? profit : max_profit;
        min_stock = price < min_stock ? price : min_stock;
    };
    return max_profit;
};