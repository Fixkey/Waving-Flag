# Waving-Flag
Waving flag made with Unity shader (Unity ver. 2019.3.0a4).
You can adjust it's Speed, Frequency and Amplitude.

If you are looking just for the formula it's:
```c++
v.vertex.y += cos((v.vertex.x + _Time.y * _Speed) * _Frequency) * _Amplitude * (v.vertex.x - 5)

```

# DEMO

![demo](/WavingFlagDemo.gif)
