using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SapLife : Template
    {
        public static readonly Guid ID = Guid.Parse("902d66ef-b1a7-446b-b228-2c0f476c5cea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sap Life",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f00b4e2-c78f-48ff-96a2-48641bc4ff57"), Type = TextBlockType.Text, Text = "You draw the life force out of your enemies to heal your own wounds. When you cast a (spell: harm) spell and damage at least one living creature, you regain Hit Points equal to the spell level of your harm spell. If you aren't a living creature, you gain no benefit from this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0efe5045-843e-47e7-9d4d-773ee57b4d7b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
