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
    public class ShallNotRoutShallNotFalter : Template
    {
        public static readonly Guid ID = Guid.Parse("e8c0a5b4-9ba7-458f-bc7f-d85a67e37716");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shall Not Rout, Shall Not Falter",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e639fb66-bf75-46ed-8d33-669e99b96acc"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Feat>("shall not rout, shall not falter", Feats.Instances.ShallNotRoutShallNotFalter.ID)} focus spell. If you don't already have one, you gain a focus pool of 1 Focus Point, which you can regain using the {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} activity to recite the Crimson Oath and meditate on its teachings. If you already have a focus pool, increase the number of Focus Points in your focus pool by 1. Your knight reclaimant focus spells are divine spells; when you gain this feat, you become trained in divine spell attacks and spell DCs and your spellcasting ability is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3972b58b-0252-46cc-8bc3-1d88bc64f6c9"), Feats.Instances.KnightReclaimantDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("401aef69-c45c-41d4-bc1c-449e53842e98"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
