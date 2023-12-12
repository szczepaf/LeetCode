public class _28 {
    public int strStr(String haystack, String needle) {
        int H = haystack.length(); //9
        int N = needle.length(); //3

        for (int i = 0; i <= H - N; i++){
            if (haystack.substring(i, i + N).equals(needle)) return i;
        }
        return -1;
    }
}
