using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VersatileSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("0612364f-4ea2-4e55-bb26-58d91405a2a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Versatile Spellstrike",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("196209f1-b3bf-4164-9f8f-cc3ce5a20023"), Type = TextBlockType.Text, Text = "You can channel the entire realm of possibilities of your (item: spellbook) into an attack. Once during your daily preparations, you can use a spell slot to hold that infinite potential, rather than using it to prepare a spell. When you make a (feat: Spellstrike), you can expend this special spell slot to immediately prepare and cast a spell from your (item: spellbook) at 2 levels lower than the slot’s level. (As normal for preparing spells, you can use a spell of an even-lower level, heightening it accordingly.) You don’t have any spell prepared in that slot until you cast from that slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9f3b275f-660c-4859-888d-a6eb19fe6793"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e734ec3-76ab-4536-9b72-a49bdcdcea8f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
