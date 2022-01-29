using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlanarBond : Template
    {
        public static readonly Guid ID = Guid.Parse("e2acf3a3-3b7a-483a-9a55-150951cfa5f7");

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
            yield return new TextBlock { Id = Guid.Parse("8bbfcbfc-ec6b-4d0a-854a-e6ffc8e4d2e3"), Type = TextBlockType.Text, Text = $"When you manifest the essence form, choose one damage type: acid, chaotic, cold, electricity, evil, fire, good, lawful, negative, positive, or sonic. You gain resistance equal to your level + 2 to damage of the selected type." };
            yield return new TextBlock { Id = Guid.Parse("2c7c08a1-64c8-4e35-abe0-c0fb2f5bbe1d"), Type = TextBlockType.Text, Text = $"__Corruption Flaw__ You gain weakness 1 to all damage." };
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
                Id = Guid.Parse("0a11cbb2-f981-484e-9883-551ac32939fc"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
