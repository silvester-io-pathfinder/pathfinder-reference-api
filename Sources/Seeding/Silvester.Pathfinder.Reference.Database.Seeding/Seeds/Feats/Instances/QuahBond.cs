using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuahBond : Template
    {
        public static readonly Guid ID = Guid.Parse("1d31d33a-8c84-44f6-8b3d-9c902dcf78bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quah Bond",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f01d5354-a142-463d-b600-0f492b0f6b75"), Type = TextBlockType.Text, Text = "~ Access: Shoanti ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("3ce23bda-a8e5-48a5-996e-44e210a61ff5"), Type = TextBlockType.Text, Text = "You grew up among the Shoanti tribes, with the spirits watching over you, and they offer you guidance. You gain the trained proficiency rank in the skill listed for your quah (or another skill of your choice, if you're already trained in that skill). You gain the (feat: Assurance) skill feat in that skill, as the spirits' help guides your actions." };
            yield return new TextBlock { Id = Guid.Parse("6411e5ca-858d-43d5-b008-4aec07b633cd"), Type = TextBlockType.Text, Text = "~ Lyrune-Quah: Religion" };
            yield return new TextBlock { Id = Guid.Parse("ddba55ac-1234-4ea5-916c-55c883df3e29"), Type = TextBlockType.Text, Text = "~ Shadde-Quah: Athletics" };
            yield return new TextBlock { Id = Guid.Parse("f8203b9f-2628-4989-8869-568e9feaf00f"), Type = TextBlockType.Text, Text = "~ Shriikirri-Quah: Nature" };
            yield return new TextBlock { Id = Guid.Parse("c7190c07-d8b6-42ff-b381-fc36d0b3f6c1"), Type = TextBlockType.Text, Text = "~ Shundar-Quah: Diplomacy" };
            yield return new TextBlock { Id = Guid.Parse("cb16e68b-c53c-4529-b599-f03df0cd0965"), Type = TextBlockType.Text, Text = "~ Sklar-Quah: Intimidation" };
            yield return new TextBlock { Id = Guid.Parse("48c81caf-a448-4691-876e-809fd910b432"), Type = TextBlockType.Text, Text = "~ Skoan-Quah: Medicine" };
            yield return new TextBlock { Id = Guid.Parse("0231ead4-89a8-46de-822e-ac9f1ca4aa4e"), Type = TextBlockType.Text, Text = "~ Tamiir-Quah: Acrobatics" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("218af640-de73-4232-ab40-00d27f7023f5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
