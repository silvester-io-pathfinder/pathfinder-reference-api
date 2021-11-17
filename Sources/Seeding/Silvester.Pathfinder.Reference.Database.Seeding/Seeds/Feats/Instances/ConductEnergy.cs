using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConductEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("809bf23c-cb9d-4850-a190-1c7a457bd451");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conduct Energy",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d8e67a2-a2bd-4d47-91d1-7c3ea335aeb2"), Type = TextBlockType.Text, Text = "You channel energy into your weapon. The weapon deals 1 additional damage per weapon damage die until the start of your next turn. This damage type matches the trait of the triggering action or spell. If your triggering action or spell had multiple eligible traits, you select one of those traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39fc8f2b-7917-4201-80a8-ab7115a291d1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
