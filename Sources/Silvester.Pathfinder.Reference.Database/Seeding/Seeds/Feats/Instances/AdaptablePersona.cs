using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdaptablePersona : Template
    {
        public static readonly Guid ID = Guid.Parse("fbe6a5c7-6cef-4683-b8f2-67e35c9936c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adaptable Persona",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1604eeb-2741-4ff7-b082-2eb88fed90c9"), Type = TextBlockType.Text, Text = "When you manifest the essence form, gain your choice of a climb Speed or swim Speed equal to your land Speed. If you’re 8th level or higher, you can choose a fly Speed instead." };
            yield return new TextBlock { Id = Guid.Parse("94944fd4-4e31-40df-8970-56861620bc48"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You take a –10-foot penalty to all your Speeds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bce6ddb-2c33-4809-b0bc-2c9a02c43498"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
