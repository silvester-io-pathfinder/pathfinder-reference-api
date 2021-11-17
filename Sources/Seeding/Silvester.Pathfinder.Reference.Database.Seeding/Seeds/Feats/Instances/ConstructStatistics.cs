using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConstructStatistics : Template
    {
        public static readonly Guid ID = Guid.Parse("5d85305b-0a82-442c-8a2e-7a2806b131c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Construct Statistics",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f448b30a-9597-4583-8aff-4565a2e69cf5"), Type = TextBlockType.Text, Text = "__(feat: Construct Companion Rules)__" };
            yield return new TextBlock { Id = Guid.Parse("37eaf1bb-3c40-4fe7-b40f-95997e091cf8"), Type = TextBlockType.Text, Text = "Str|Dex|Con|Int|Wis|Cha" };
            yield return new TextBlock { Id = Guid.Parse("5dca58a9-d9da-4acf-99b6-659e51bce416"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:|:-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("d5318538-2a4c-4013-b593-40170d1ba792"), Type = TextBlockType.Text, Text = "+{INNOVATION_SCORE_STR.GET_TOTAL_MOD}|+{INNOVATION_SCORE_DEX.GET_TOTAL_MOD}|+{INNOVATION_SCORE_CON.GET_TOTAL_MOD}|{INNOVATION_SCORE_INT.GET_TOTAL_MOD}|+{INNOVATION_SCORE_WIS.GET_TOTAL_MOD}|+{INNOVATION_SCORE_CHA.GET_TOTAL_MOD}" };
            yield return new TextBlock { Id = Guid.Parse("b1182cee-022f-4b62-82fc-6b755a13a407"), Type = TextBlockType.Text, Text = "Fortitude|Will|Reflex" };
            yield return new TextBlock { Id = Guid.Parse("0a87877e-b422-45bb-9367-347ea4d8245d"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("814efb1a-428c-4703-bea8-6e11772f3cfd"), Type = TextBlockType.Text, Text = "+{INNOVATION_SAVE_FORT.GET_TOTAL}|+{INNOVATION_SAVE_WILL.GET_TOTAL}|+{INNOVATION_SAVE_REFLEX.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("0928800b-94eb-417f-b74b-ff1a5c1c5243"), Type = TextBlockType.Text, Text = "Name|Value" };
            yield return new TextBlock { Id = Guid.Parse("b877435c-a70d-446b-b620-8401166ca9e2"), Type = TextBlockType.Text, Text = ":--|:--" };
            yield return new TextBlock { Id = Guid.Parse("81c6dc6f-c613-4e1c-b922-d623c442ffa3"), Type = TextBlockType.Text, Text = "Traits|{INNOVATION_TRAITS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("584e3fd8-eac5-457c-a302-0dfd939e1c8d"), Type = TextBlockType.Text, Text = "Unarmed Attacks|{INNOVATION_UNARMED_ATTACKS}" };
            yield return new TextBlock { Id = Guid.Parse("07ae47c4-9785-4b5b-85ff-6d30038d1216"), Type = TextBlockType.Text, Text = "Unarmored Defense|{INNOVATION_UNARMORED_DEFENSE}" };
            yield return new TextBlock { Id = Guid.Parse("6ba272f6-9e0c-44f3-ac53-610bae16785d"), Type = TextBlockType.Text, Text = "Hit Points|{INNOVATION_HP.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("30d93b92-5705-4ef0-84cc-f5be7fcaee24"), Type = TextBlockType.Text, Text = "Resistances|{INNOVATION_RESIST.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("d37531cd-0651-4e8c-9c2c-1ec091442379"), Type = TextBlockType.Text, Text = "Speeds|{INNOVATION_SPEEDS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("5697a07a-b9e9-4062-b493-17e625046c59"), Type = TextBlockType.Text, Text = "Size|{INNOVATION_SIZE.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("cf50de2c-abef-4897-88b2-284053b06310"), Type = TextBlockType.Text, Text = "Perception|+{INNOVATION_PERCEPTION.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("f33d09c9-e81e-4368-ac8b-917844b55148"), Type = TextBlockType.Text, Text = "Senses|{INNOVATION_SENSES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("5a3cf258-52f8-482c-bb3f-8a45a0e4a423"), Type = TextBlockType.Text, Text = "Athletics|+{INNOVATION_ATHLETICS.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("460b50fc-e218-4127-b048-c4d21db27dba"), Type = TextBlockType.Text, Text = "Acrobatics|+{INNOVATION_ACROBATICS.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("751ca434-6573-40fb-8a72-a9a6b36d5604"), Type = TextBlockType.Text, Text = "Intimidation|+{INNOVATION_INTIMIDATION.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("d9554e64-4f63-4270-bd03-81d88c5959b2"), Type = TextBlockType.Text, Text = "Stealth|+{INNOVATION_STEALTH.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("aeaf6da8-7f2f-4109-9407-5831d148b04a"), Type = TextBlockType.Text, Text = "Survival|+{INNOVATION_SURVIVAL.GET_TOTAL}" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed047e8f-4978-41be-b571-5580150edb37"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
