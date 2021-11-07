using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuahBond : Template
    {
        public static readonly Guid ID = Guid.Parse("013864f3-9cab-43ea-978c-60f52dc72d4f");

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
            yield return new TextBlock { Id = Guid.Parse("8bcf6e11-014e-4387-a1e7-ed9d89f9ee69"), Type = TextBlockType.Text, Text = "~ Access: Shoanti ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("953de66c-298c-4c68-9dca-a1d9dbb7141e"), Type = TextBlockType.Text, Text = "You grew up among the Shoanti tribes, with the spirits watching over you, and they offer you guidance. You gain the trained proficiency rank in the skill listed for your quah (or another skill of your choice, if you’re already trained in that skill). You gain the (feat: Assurance) skill feat in that skill, as the spirits’ help guides your actions." };
            yield return new TextBlock { Id = Guid.Parse("34b00b53-6880-4822-b91a-bb69e07361ea"), Type = TextBlockType.Text, Text = "~ Lyrune-Quah: Religion" };
            yield return new TextBlock { Id = Guid.Parse("f256336e-0ee5-41e1-991d-a7b2f952b365"), Type = TextBlockType.Text, Text = "~ Shadde-Quah: Athletics" };
            yield return new TextBlock { Id = Guid.Parse("33e78992-4a4b-4d0b-9c70-8873892ead5d"), Type = TextBlockType.Text, Text = "~ Shriikirri-Quah: Nature" };
            yield return new TextBlock { Id = Guid.Parse("68cf5314-2f1c-443d-99d8-aaabc0af8eaf"), Type = TextBlockType.Text, Text = "~ Shundar-Quah: Diplomacy" };
            yield return new TextBlock { Id = Guid.Parse("1274986b-ca00-4301-89c8-7bea90b07ad7"), Type = TextBlockType.Text, Text = "~ Sklar-Quah: Intimidation" };
            yield return new TextBlock { Id = Guid.Parse("07fe23ad-60ba-4f67-ba08-739f8ddb484b"), Type = TextBlockType.Text, Text = "~ Skoan-Quah: Medicine" };
            yield return new TextBlock { Id = Guid.Parse("7ece0413-d1f3-44ab-8a06-823302128f2f"), Type = TextBlockType.Text, Text = "~ Tamiir-Quah: Acrobatics" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30fc2201-2c0d-46b8-8a0c-c26acecf3d3d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
