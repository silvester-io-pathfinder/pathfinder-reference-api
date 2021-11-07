using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PatronsBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("4b71ee71-b77c-408c-9e43-9b2007fa1c16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Patron's Breadth",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58d049fc-4550-4727-ac36-38e5025fc6fc"), Type = TextBlockType.Text, Text = "You can cast more spells each day. Increase the spell slots you gain from witch archetype feats by 1 for each spell level other than your two highest witch spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9ea3ce38-70bc-42dd-84e8-583c68b6936c"), Feats.Instances.BasicWitchSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65f9c668-23b8-45a3-9ee9-12454fdd2e7b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
