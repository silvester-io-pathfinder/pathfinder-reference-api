using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodlineBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("24fb9ac2-4fa8-4cbc-a0ef-1fc10bab60b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloodline Breadth",
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
            yield return new TextBlock { Id = Guid.Parse("70de74e3-a73d-4d2a-8f53-075aaf63b390"), Type = TextBlockType.Text, Text = "Your repertoire expands, and you can cast more spells of your bloodline’s tradition each day. Increase the number of spells in your repertoire and number of spell slots you gain from sorcerer archetype feats by 1 for each spell level other than your two highest sorcerer spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2efd4e5a-6fb5-4c2d-9997-271087ab966a"), Feats.Instances.BasicSorcererSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e9c3a98-05f7-4a33-a444-1f4cde13ea1a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
