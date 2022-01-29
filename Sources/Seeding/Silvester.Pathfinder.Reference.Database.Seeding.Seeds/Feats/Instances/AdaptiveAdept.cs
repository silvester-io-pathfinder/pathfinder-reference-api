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
    public class AdaptiveAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("35d30e3b-69a2-4995-a617-daec0b47d53e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adaptive Adept",
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
            yield return new TextBlock { Id = Guid.Parse("780a3c4a-7279-47a7-8513-e2157eb0d0e4"), Type = TextBlockType.Text, Text = $"You've continued adapting your magic to blend your class's tradition with your adapted tradition. Choose a cantrip or 1st-level spell from the same magical tradition as your cantrip from {ToMarkdownLink<Models.Entities.Feat>("Adapted Cantrip", Feats.Instances.AdaptedCantrip.ID)}. You gain that spell, adding it to your spell repertoire, spellbook, or prepared spells just like the cantrip from {ToMarkdownLink<Models.Entities.Feat>("Adapted Cantrip", Feats.Instances.AdaptedCantrip.ID)}. You can cast this spell as a spell of your class's magical tradition. If you choose a 1st-level spell, you don't gain access to the heightened versions of that spell, meaning you can't prepare them if you prepare spells and you can't learn them or select the spell as a signature spell if you have a spell repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f995f41a-209e-4393-b009-46a19c410758"), Feats.Instances.AdaptedCantrip.ID);
            builder.HaveSpecificSpellSlotLevel(Guid.Parse("1db54632-dc49-4362-8bea-07683de39d7d"), spellSlotLevel: 3);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c34cb2b-51b0-496d-817d-b898acea2101"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
