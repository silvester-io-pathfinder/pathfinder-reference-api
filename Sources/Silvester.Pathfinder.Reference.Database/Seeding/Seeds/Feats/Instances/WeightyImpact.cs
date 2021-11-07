using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeightyImpact : Template
    {
        public static readonly Guid ID = Guid.Parse("02a9f353-80b0-4542-8547-ba699c866d29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weighty Impact",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62d198b0-0bf6-49bc-8df5-6cecf14a79c3"), Type = TextBlockType.Text, Text = "Your eidolon knocks enemies down. Choose one of the eidolon’s unarmed attacks with the (trait: trip) trait. It gains the Knockdown action (Bestiary pg. 343) for that attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77d42273-60d0-48e6-9644-55fe64b01a7f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
