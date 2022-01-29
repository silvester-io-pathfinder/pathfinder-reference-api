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
    public class ManyGuises : Template
    {
        public static readonly Guid ID = Guid.Parse("e16a7e20-0835-4a6b-b5c4-2f389135920a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Many Guises",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2bcbd7ad-2274-494f-8f7b-f0e2b1ea05c5"), Type = TextBlockType.Text, Text = $"You can take on any number of mundane guises. Whenever you change your identity, instead of taking on your social or vigilante identity, you can become someone completely ordinary. This identity isn't a specific individual – rather, you become a nondescript member of your ancestry, of any gender, with a neutral alignment and a mundane occupation such as common laborer, farmer, or peasant. Spells and abilities detect you as if you were this ordinary identity, rather than either of your two real identities, unless they succeed at a counteract check against your Deception DC. You can't use either {ToMarkdownLink<Models.Entities.Trait>("social", Traits.Instances.Social.ID)} abilities or {ToMarkdownLink<Models.Entities.Trait>("vigilante", Traits.Instances.Vigilante.ID)} abilities while in this identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ba322573-333f-4ec5-9608-38556899e862"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("bee3b939-77be-472b-97ae-1eeb3ad26a91"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5f861596-9ec0-4979-b97f-d8b62a2940df"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9563cac-6b54-4828-9507-b380673ea934"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
