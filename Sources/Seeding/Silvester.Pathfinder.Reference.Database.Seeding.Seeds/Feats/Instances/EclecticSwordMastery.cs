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
    public class EclecticSwordMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("cb4159d3-5793-4e9f-8e27-df5e4c8594cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Sword Mastery",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c594fac0-f9d3-4635-bd88-186f47df57b5"), Type = TextBlockType.Text, Text = $"You instinctively learn how to use a sword with just a few practice swings. You change one of the swords designated in your {ToMarkdownLink<Models.Entities.Feat>("Tengu Weapon Familiarity", Feats.Instances.TenguWeaponFamiliarity.ID)} to a new one that you're wielding, provided the sword meets the specifications of {ToMarkdownLink<Models.Entities.Feat>("Tengu Weapon Familiarity", Feats.Instances.TenguWeaponFamiliarity.ID)}. You can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a sword as part of this activity, designating the sword as part of drawing it; disrupting that {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action prevents you from designating it as one of your swords. This designation lasts until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("75382860-ec43-421f-8192-7dfd7e72dc72"), Feats.Instances.EclecticSwordTraining.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d347229-5ce6-4f0b-a4d4-5f49c61f8d55"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
