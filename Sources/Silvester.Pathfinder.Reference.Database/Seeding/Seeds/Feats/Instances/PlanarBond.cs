using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlanarBond : Template
    {
        public static readonly Guid ID = Guid.Parse("88c23cd8-e2f4-4eed-81aa-d0a6813c8f0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Planar Bond",
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
            yield return new TextBlock { Id = Guid.Parse("0882308f-8b97-4884-8331-66e62fa39779"), Type = TextBlockType.Text, Text = "When you manifest the essence form, choose one damage type: acid, chaotic, cold, electricity, evil, fire, good, lawful, negative, positive, or sonic. You gain resistance equal to your level + 2 to damage of the selected type." };
            yield return new TextBlock { Id = Guid.Parse("e3f1fad0-cc02-4617-be31-048502192028"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You gain weakness 1 to all damage." };
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
                Id = Guid.Parse("8ddadf99-2d4c-4d3e-91b2-30e3cea2fe3e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
