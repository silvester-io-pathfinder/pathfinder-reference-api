using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstrumentOfZeal : Template
    {
        public static readonly Guid ID = Guid.Parse("bd468bac-a4f0-4e4f-9503-abaaa4bdae33");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instrument of Zeal",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5a1c357-d99a-4d6b-a116-6f9a34065aca"), Type = TextBlockType.Text, Text = $"Divine energy fills your weapon. Whenever you critically hit a foe with {ToMarkdownLink<Models.Entities.Feat>("Blade of Justice", Feats.Instances.BladeOfJustice.ID)} or a {ToMarkdownLink<Models.Entities.Feat>("Retributive Strike", Feats.Instances.RetributiveStrike.ID)}, your attack adds an extra damage die and the target is slowed 1 on its next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("2d505500-a051-4806-a7ce-7d27e271d025"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("044886af-c0a0-4a33-8989-c60966dcd4ef"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c7de381-b8c2-45f8-bb81-2a602d22efd2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
