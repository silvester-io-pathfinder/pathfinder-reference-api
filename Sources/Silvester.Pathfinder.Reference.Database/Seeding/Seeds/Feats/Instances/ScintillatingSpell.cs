using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScintillatingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("8dd5d36c-3aa6-4535-a4d7-f674a265a5ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scintillating Spell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3721084e-d0f0-4cab-b502-ea7f4df3e69b"), Type = TextBlockType.Text, Text = "Your spells become a radiant display of light and color. If your next action is to (action: Cast a Spell) that doesn’t have the (trait: darkness) trait, has no duration, and requires creatures to attempt a Reflex save, the spell explodes in a spray of scintillating lights, in addition to its other effects. Each creature that failed its Reflex save against the spell is dazzled for 1 round, and those who critically failed are instead blinded for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("26d4bdc6-ef15-4291-b4d7-8b8968f402e1"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89dcd8dd-ad30-48be-bfe2-a78fb16d6af4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
