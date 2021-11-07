using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormOfTheFiend : Template
    {
        public static readonly Guid ID = Guid.Parse("5f47023c-8227-4487-8c53-384dbc2fff5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form of the Fiend",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can select this feat only at 1st level, and you can't retrain into or out of this feat, nor can you change the type of attack you gained.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("954a7f5d-7c59-4fca-a8fd-04677b73dae2"), Type = TextBlockType.Text, Text = "Part of your body has an obvious, fiendish appearance. Your hands end in razor-sharp claws, you have hooves instead of feet, sharp teeth fill your mouth, or a whipping tail extends from your spine. You gain your choice of one of the following unarmed attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbd80bb0-caa5-4b59-be35-eb150c8cdd90"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
