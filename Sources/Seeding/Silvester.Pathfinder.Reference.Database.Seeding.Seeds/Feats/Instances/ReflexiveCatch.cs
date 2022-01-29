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
    public class ReflexiveCatch : Template
    {
        public static readonly Guid ID = Guid.Parse("cd9dc648-bc5c-41c6-b5c4-934c4cfcf923");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflexive Catch",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An item falls within your reach or an attacker fails an attack roll to hit you or a creature within your reach with a thrown weapon.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4a9ca5f-01c7-451f-ad9f-37a23eaff718"), Type = TextBlockType.Text, Text = $"You grab the triggering item. If you are {ToMarkdownLink<Models.Entities.Feat>("Juggling", Feats.Instances.Juggle.ID)}, you can immediately add the item to the objects you're {ToMarkdownLink<Models.Entities.Feat>("Juggling", Feats.Instances.Juggle.ID)} as a free action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} and {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("dd578320-0ddc-4ad8-9e8d-c5b79ad41839"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificFeat(Guid.Parse("85b5cf4a-a20b-4c95-bd60-b38367dea180"), Feats.Instances.JugglerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("816a4946-1cca-451f-8e06-4d4b00b8cb28"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
