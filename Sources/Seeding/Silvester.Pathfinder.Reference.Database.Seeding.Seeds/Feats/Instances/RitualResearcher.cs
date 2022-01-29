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
    public class RitualResearcher : Template
    {
        public static readonly Guid ID = Guid.Parse("fd5fa876-e697-4679-92b5-9d50859f4918");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ritual Researcher",
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
            yield return new TextBlock { Id = Guid.Parse("2bd99101-884e-4a55-b4f0-ac20a753ef68"), Type = TextBlockType.Text, Text = $"Careful research into the art of rituals has made you better at performing them. You gain a +2 circumstance bonus to all primary and secondary checks you attempt as part of casting a ritual." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("5a2d71f5-5b75-4275-ab89-2f09f42a386f"), Muses.Instances.Enigma.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0828c30e-286c-43cf-9ae0-3f725fe223dd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fafd97e3-8d63-485d-90b7-f8c7c6df721a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
