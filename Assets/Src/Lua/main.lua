print("main.lua is called!")

require("Assets/Src/lua/event")

main = {}

local this = main

function main:GetInstance()
    return this
end


main.lp = function(name, process)
    print(name,process)
    if process >= 1
    then
        local prefab = CS.AssetBundleManager.Instance:LoadAsset("Main","UI","Canvas")
        local canvas = CS.UnityEngine.GameObject.Instantiate(prefab)
        local child = canvas.transform:Find("Content")
        local textComponent = child:GetComponent(typeof(CS.UnityEngine.UI.Text))
        textComponent.text = "今日公告：更新了 快给你的智商充值吧"
    end
end

function main:init()
    CS.AssetBundleManager.Instance:LoadAssetBundle("Main","UI",this.lp)
end