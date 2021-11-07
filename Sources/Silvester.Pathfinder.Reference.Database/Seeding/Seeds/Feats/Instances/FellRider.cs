using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FellRider : Template
    {
        public static readonly Guid ID = Guid.Parse("263bc034-e5b2-456f-9943-8af033342643");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fell Rider",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2111e779-bd0b-43a3-8ad1-65e36268a40f"), Type = TextBlockType.Text, Text = "You have trained with your animal companion to become a terrifying, unified juggernaut on the battlefield. Your animal companion becomes trained in Intimidation. If your animal companion uses Support while serving as your mount, it grants you the effects of the (action: Aid) reaction on your first Intimidation check to (action: Demoralize) on the same turn, even though it can’t take reactions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAnimalCompanionAmount(Guid.Parse("e371934c-710f-405c-963c-f8aa6b47eeb4"), Comparators.GreaterThanOrEqualTo, amount: 1);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8cd308a-1606-42b0-b442-02fddfada644"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
