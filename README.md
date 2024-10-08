# 本仓库已不再更新，已经整合到：https://github.com/UnrealMultiple/TShockPlugin，后续更新均会发布至此仓库
# This repository is no longer updated and has been integrated into: https://github.com/UnrealMultiple/TShockPlugin. All future updates will be published there.
# AutoTeamPlus 插件介绍

## 概述

AutoTeamPlus 是一个为 Terraria 游戏服务器设计的插件，旨在实现自动分配玩家到特定队伍的功能。这个插件由 "十七改，肝帝熙恩改" 开发，适用于 TShockAPI 服务器。

## 主要功能

- **自动队伍分配**：根据玩家的组别自动将玩家分配到相应的队伍。
- **配置灵活性**：允许管理员通过配置文件轻松设置队伍与玩家组别的映射关系。
- **命令行控制**：管理员可以通过聊天命令启用或禁用插件。
- **事件监听**：在玩家加入游戏、登录后自动处理队伍分配。

## 使用方法

### 启用/禁用插件

玩家可以通过以下命令来启用或禁用 AutoTeamPlus 插件：

```
/autoteam on  # 启用插件
/autoteam off # 禁用插件
```

### 配置文件

插件的配置文件位于 `TShock.SavePath` 目录下的 `AutoTeam.json` 文件。配置文件允许管理员定义组别与队伍之间的映射关系。例如：

```json
{
  "组的队伍": {
    "default": "red",
    "亲爱的": "红队",
    // 更多组别与队伍的映射...
  },
  "开启插件": true
}
```

### 队伍分配

当玩家加入游戏或登录时，插件会根据其所属的组别自动分配到相应的队伍。如果组别没有在配置文件中定义，玩家将被分配到默认的队伍（例如 "red"）。


## 权限

```
noautoteam -免检测权限
```

## 支持与反馈
- 如果您在使用过程中遇到问题或有任何建议，欢迎在官方论坛或社区中提出issues或pr。
- github仓库：https://github.com/THEXN/AutoTeam
