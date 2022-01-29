using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueDebilitatingBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("3bf88a3a-ff7e-4309-9ade-fce998d42157");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Debilitating Bomb",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("314e666c-c881-4417-80cd-196b2f0c9029"), Type = TextBlockType.Text, Text = $"Ever inventive, you have discovered increasingly devastating ways for your bombs to impede and hamper your foes. When you use {ToMarkdownLink<Models.Entities.Feat>("Debilitating Bomb", Feats.Instances.DebilitatingBomb.ID)}, add the following to the list of effects you can choose from: enfeebled 2, stupefied 2, or a -15-foot status penalty to Speeds. If you instead apply one of the effects listed in {ToMarkdownLink<Models.Entities.Feat>("Debilitating Bomb", Feats.Instances.DebilitatingBomb.ID)}, the target avoids the effect only if the result of its saving throw is a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("807e8e06-de25-4f3f-b137-2e7d93703646"), Feats.Instances.GreaterDebilitatingBomb.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f785ab75-fc20-4b15-ab7b-025c20658716"), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8e008e1-a000-4531-86b4-63cfd007371b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
