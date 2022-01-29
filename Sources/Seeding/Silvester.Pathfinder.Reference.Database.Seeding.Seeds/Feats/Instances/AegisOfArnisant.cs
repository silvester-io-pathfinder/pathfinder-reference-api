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
    public class AegisOfArnisant : Template
    {
        public static readonly Guid ID = Guid.Parse("31f7db78-a0ec-4002-9576-2e7f6da5466a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aegis of Arnisant",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("910c6d12-e8e3-4e66-a130-1c73e8799f40"), Type = TextBlockType.Text, Text = $"Inspired by the tale of Arnisant, you transform your shield into a magic ward. Until the beginning of your next turn, you gain the following reaction:" };
            yield return new TextBlock { Id = Guid.Parse("d992b4e8-c406-46eb-b5b4-af8d7d8399c6"), Type = TextBlockType.Text, Text = $"~ Absorb into the Aegis: REACTION {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)}) **Trigger** An enemy casts a spell that targets you or an ally within 15 feet of you; **Effect** You interpose your shield's ward against the spell. Attempt a counteract check, using your Religion modifier as your counteract modifier. On a success, the spell is counteracted and your shield takes damage equal to four times the spell level as it absorbs and disperses the magical energy. On a failure, the shield takes damage equal to twice the spell's level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ce8e4bed-47ca-4290-b946-45f6175a220f"), Feats.Instances.KnightVigilantDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("8a749859-d1ca-4a57-92f3-82f947e61fcf"), Feats.Instances.ShieldBlock.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ed3fea79-5738-41df-b6df-e9b5809e5e18"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bde8499e-4c4e-4a11-9d47-79f7c52677c1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
