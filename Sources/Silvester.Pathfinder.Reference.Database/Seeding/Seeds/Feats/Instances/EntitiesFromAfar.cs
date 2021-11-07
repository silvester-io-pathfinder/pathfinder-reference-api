using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EntitiesFromAfar : Template
    {
        public static readonly Guid ID = Guid.Parse("8d9a8a6d-c8f5-486d-b6f6-ff5fb9ec9389");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Entities from Afar",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d32252b9-720b-406d-817a-93dba9c84d8e"), Type = TextBlockType.Text, Text = "You can call in aberrations to fight for you or to answer questions. You can cast (spell: summon entity) as an innate occult spell once per day. If you couldn&#39;t already cast occult spells, these spells use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for occult spells; if you could already cast occult spells, your proficiency in spell attack rolls and spell DCs for occult spells increases to expert." };
            yield return new TextBlock { Id = Guid.Parse("c26885ab-6dc1-4e8e-8fa6-a195aeb93175"), Type = TextBlockType.Text, Text = "As soon as the aberration arrives, instead of giving it any other commands, you can demand that it help you with a single question you pose to it. For the creature to effectively answer, you must (action: Sustain the Spell | Sustain a Spell) for 1 minute, and you must understand and be understood by the aberration. If you do, the aberration gives you a cryptic clue as provided by the (spell: read omens) spell, except that the clue is even more enigmatic than normal; the creature then immediately returns from whence it came without providing you any other benefit. At 16th level and every 2 levels thereafter, the (spell: summon entity) spell is heightened by 1 level (to a maximum of 8th level when you reach 20th level)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b6ba7ea2-914e-496f-ad46-4111a2f7ca17"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21d3c28e-1982-4af0-9e69-f9a9e7742cf7"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
