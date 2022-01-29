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
    public class QuickenedAttunement : Template
    {
        public static readonly Guid ID = Guid.Parse("378fc6fc-3689-45f7-b9f6-a7706d45de40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quickened Attunement",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't use Quickened Attunement and Quickened Casting in the same round.",
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b85fa80b-2628-4c2e-8fdd-5b16b5ea0869"), Type = TextBlockType.Text, Text = $"If your next action is to cast a spell that would grant your terrain attunement bonus, reduce the number of actions to cast it by 1 (to a minimum of 1 action)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8b43dff4-859b-44a6-91df-9567bb1f3eb3"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ee739be3-f2a0-481c-986b-90a116eb3ba6"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e09201e3-1ed9-49ed-a396-68c923638c92"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("dce51abd-f17d-47c9-9851-8e1c6046e7e6"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("d4c7e25b-de47-485a-86f6-8d49b4f65196"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cd7d165-96bb-4f9a-b43e-a7f845d1392b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
