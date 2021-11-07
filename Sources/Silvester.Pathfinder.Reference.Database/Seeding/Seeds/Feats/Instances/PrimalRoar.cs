using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrimalRoar : Template
    {
        public static readonly Guid ID = Guid.Parse("a77c22bb-bcd3-40bf-9948-c24887a6cf8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Roar",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd58ed32-a164-4c77-a73d-afa6b610a36d"), Type = TextBlockType.Text, Text = "Your eidolon unleashes a primal roar or other such terrifying noise that fits your eidolon’s form. Your eidolon attempts Intimidation checks to (action: Demoralize) each enemy that can hear the roar; these (action: Demoralize) attempts don’t take any penalty for not sharing a language." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc2cd0d7-773d-4275-a9fc-82c34d827985"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
