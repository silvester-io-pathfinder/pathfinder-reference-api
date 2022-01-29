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
    public class CalacasShowstopper : Template
    {
        public static readonly Guid ID = Guid.Parse("d427d9fa-7b2f-46d6-bd55-9bc656463885");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Calaca's Showstopper",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f0b815a-4855-4599-8894-6ba786d15d3b"), Type = TextBlockType.Text, Text = $"You've spent many an evening learning songs and tales featuring calacas, death's wandering minstrels. You dramatically unleash a stunning blast of sound by smashing an instrument you hold or belting out a discordant note. This has the effects of {ToMarkdownLink<Models.Entities.Spell>("synaptic pulse", Spells.Instances.SynapticPulse.ID)}, but the effect is {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} rather than {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)}. The DC is either your class DC or spell DC, whichever is higher." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ed417a3e-4b98-4d6f-bbd7-4daa2c4bf407"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Duskwalker.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Incapacitation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("698ad815-f917-4306-89e3-f142cb552151"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
