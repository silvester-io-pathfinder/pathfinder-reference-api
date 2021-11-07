using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HandOfTheApprentice : Template
    {
        public static readonly Guid ID = Guid.Parse("80a4db3b-9a11-46a9-9850-71d9c9c81f58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hand of the Apprentice",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ff69eff-4803-4a2a-b1ec-da493610baff"), Type = TextBlockType.Text, Text = "You can magically hurl your weapon at your foe. You gain the (Spell: hand of the apprentice) universalist spell. Universalist spells are a type of focus spell, much like school spells. You start with a focus pool of 1 Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("bf965dbc-47ed-4fe9-aa76-234e8a29ae51"), Classes.Instances.Wizard.ID);
            builder.HaveNoMagicSchool(Guid.Parse("129c1bd1-1823-4444-909d-770acec7fbc4"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("121386a9-f153-4e8e-b008-beea6c6dfb37"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
