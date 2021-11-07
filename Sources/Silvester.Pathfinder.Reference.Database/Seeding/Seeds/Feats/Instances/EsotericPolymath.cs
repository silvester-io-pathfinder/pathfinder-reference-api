using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericPolymath : Template
    {
        public static readonly Guid ID = Guid.Parse("c874a3b3-7082-4782-b741-e483f42db904");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Polymath",
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
            yield return new TextBlock { Id = Guid.Parse("ac2a3ff6-109e-433b-adc8-3d5102e73237"), Type = TextBlockType.Text, Text = "You keep a book of occult spells, similar to a wizard’s (item: spellbook), and can use its spells to supplement your spell repertoire. Add all the spells in your repertoire to this book for free. You can use the Occultism skill to (action: Learn Spells | Learn a Spell) and add them to your (item: spellbook) by paying the appropriate cost, similar to a wizard." };
            yield return new TextBlock { Id = Guid.Parse("3bb2d3b9-8a4c-4c34-bd7e-e06d00b6a7e2"), Type = TextBlockType.Text, Text = "During your daily preparations, choose any one spell from your book of occult spells. If that spell is already in your spell repertoire, you can treat it as an additional signature spell that day. If it isn’t in your repertoire, treat it as though it were until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("ebf28b8a-6944-4e8f-a9e5-dc9dd88a2ede"), Muses.Instances.Polymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa467bae-3468-4ada-a9f0-6e439bbec71e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
