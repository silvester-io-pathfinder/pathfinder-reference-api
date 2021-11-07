using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SimpleCrystalMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("80ab99f9-843a-4380-97ee-5c44e5165a4a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Simple Crystal Magic",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5e01d3d-42a9-47e6-9bb7-b701c8c25efe"), Type = TextBlockType.Text, Text = "As long as you meditate before a gemstone worth at least 10 gp as part of your daily preparations, you are capable of seeing magic as flowing runes that reveal information about magic objects, and you can scribe a personal rune that represents you. You gain the (spell: read aura) and (spell: sigil) cantrips. You cast these cantrips as arcane innate spells at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9a5fdd08-3393-4c53-852c-d4a2b2ad1528"), Feats.Instances.CrystalKeeperDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7834b540-a22d-4226-aff1-a3ee465fa92f"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
