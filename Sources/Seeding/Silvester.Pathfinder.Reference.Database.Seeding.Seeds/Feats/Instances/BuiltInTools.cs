using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BuiltInTools : Template
    {
        public static readonly Guid ID = Guid.Parse("fee194c6-0173-4f1c-ad2b-a085657e1172");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Built-In Tools",
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
            yield return new TextBlock { Id = Guid.Parse("8662b423-cdbe-4e43-8e77-5f9938bf4496"), Type = TextBlockType.Text, Text = $"You've built tools into your innovation so you can access and use them easily. When you take this feat, choose up to two sets of tools you own, such as {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("thieves' tools", Items.AdventuringGears.Instances.ThievesTools.ID)} or {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("healer's tools", Items.AdventuringGears.Instances.HealersTools.ID)}, that weigh a total of 2 Bulk or less. These tools become part of your innovation. The innovation's Bulk doesn't increase from this addition. As long as you are wielding, wearing, or adjacent to your innovation, you have the same quick access to these tools as the tools you are wearing, and they don't count against the usual limit of tools you can wear." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a1ee19c-1f63-4c46-9259-20eaa79767c8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
