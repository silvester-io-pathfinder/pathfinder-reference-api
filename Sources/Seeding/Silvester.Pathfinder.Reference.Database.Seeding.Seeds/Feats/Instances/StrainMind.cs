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
    public class StrainMind : Template
    {
        public static readonly Guid ID = Guid.Parse("31698788-2bb2-4775-b59f-3043d180890c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strain Mind",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You cast a psi cantrip.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("821c998d-0172-4def-9d35-32d78005bd9a"), Type = TextBlockType.Text, Text = $"You strain your body beyond its limits to use an amp even when your mental power is depleted. You apply an amp you know to the spell. Instead of paying the normal Focus Point cost, you lose Hit Points equal to double the level of the amped psi cantrip as you bleed from your nose or suffer some other visible sign of strain." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f004a3e2-6b9c-44cd-bdd7-412dbe2fcd67"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
