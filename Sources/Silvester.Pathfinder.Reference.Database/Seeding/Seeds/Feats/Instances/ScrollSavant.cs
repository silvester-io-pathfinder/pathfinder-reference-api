using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollSavant : Template
    {
        public static readonly Guid ID = Guid.Parse("dd14801d-9741-448b-8c06-e020209b7c45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scroll Savant",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32c365c8-bad0-448e-8c43-280250d67481"), Type = TextBlockType.Text, Text = "During your daily preparations, you can create two temporary scrolls containing arcane spells from your spellbook. These scrolls follow the normal rules for scrolls (page 564), with some additional restrictions. Each scroll must be of a different spell level, and both spell levels must be 2 or more levels lower than your highest-level spell. Any scrolls you create this way become non-magical the next time you make your daily preparations. A temporary scroll has no value." };
            yield return new TextBlock { Id = Guid.Parse("7e280821-6bbe-4b33-9e76-60d47ce760f8"), Type = TextBlockType.Text, Text = "If you have master proficiency in arcane spell DCs, you can create three temporary scrolls during your daily preparations, and if you have legendary proficiency, you can create four temporary scrolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("742ea699-e4ff-49bf-8712-5b7461f29404"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0d11eb6-e1ed-446d-bfac-6947cae18859"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
