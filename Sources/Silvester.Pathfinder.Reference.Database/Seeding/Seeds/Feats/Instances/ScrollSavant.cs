using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollSavant : Template
    {
        public static readonly Guid ID = Guid.Parse("7bcabeb3-5396-45c0-9b4a-1295b76153b5");

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
            yield return new TextBlock { Id = Guid.Parse("145e7755-516e-43dc-9b87-e232f13c1b63"), Type = TextBlockType.Text, Text = "During your daily preparations, you can create two temporary scrolls containing arcane spells from your spellbook. These scrolls follow the normal rules for scrolls (page 564), with some additional restrictions. Each scroll must be of a different spell level, and both spell levels must be 2 or more levels lower than your highest-level spell. Any scrolls you create this way become non-magical the next time you make your daily preparations. A temporary scroll has no value." };
            yield return new TextBlock { Id = Guid.Parse("42080478-8234-4816-a41a-9a3b72a5235c"), Type = TextBlockType.Text, Text = "If you have master proficiency in arcane spell DCs, you can create three temporary scrolls during your daily preparations, and if you have legendary proficiency, you can create four temporary scrolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("124dd2cd-574e-4713-abc6-db1f5452c299"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("507fc015-6317-4aff-b546-969efaa5d764"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
