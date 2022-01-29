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
    public class WayfinderResonanceTinkerer : Template
    {
        public static readonly Guid ID = Guid.Parse("94b9380c-2f34-486f-b5b0-83f383cd74d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wayfinder Resonance Tinkerer",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dbf49a62-f58c-4586-a43b-0834f3c0bc70"), Type = TextBlockType.Text, Text = $"You can use the unusual resonance of your wayfinder to grant it additional effects. Choose one cantrip from the arcane, divine, occult, or primal list. You can activate your wayfinder to cast that cantrip at will. Additionally, you can Activate your wayfinder with a ONE-ACTION (envision) activation to transform it into a nondescript pin or brooch to hide your affiliation with the Pathfinder Society. This transformation lasts for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("064712d3-c8d7-4092-b5c6-65788a0720e1"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("162aba6f-ccb3-46d8-8dbf-ed59364d00de"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
