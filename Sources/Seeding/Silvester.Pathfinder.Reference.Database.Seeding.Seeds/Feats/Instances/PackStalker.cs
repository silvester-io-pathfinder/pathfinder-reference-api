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
    public class PackStalker : Template
    {
        public static readonly Guid ID = Guid.Parse("b0e8fbb0-8c07-4fe9-a73b-4168ab56e2a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pack Stalker",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cc86a71-b3af-4f6a-b569-cadd16b0740b"), Type = TextBlockType.Text, Text = $"Ambushes are an honored gnoll tradition. You gain the {ToMarkdownLink<Models.Entities.Feat>("Terrain Stalker", Feats.Instances.TerrainStalker.ID)} feat and can extend its effects to a single ally so long as they remain within 10 ft. of you. If you have master proficiency in Stealth, you can extend the effect to two allies. If you have legendary proficiency in Stealth, you can extend it to four allies." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ae5ec189-72a8-4662-b725-b0148707aba8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificFeat(Guid.Parse("e5970fdd-f7e0-448e-ba93-15986c49c410"), Feats.Instances.PackHunter.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnoll.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54d0bc98-b615-4aee-9d2c-1f7cc2ab70b4"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
