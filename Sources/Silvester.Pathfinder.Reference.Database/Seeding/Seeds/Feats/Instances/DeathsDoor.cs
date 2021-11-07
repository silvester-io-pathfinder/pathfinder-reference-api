using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeathsDoor : Template
    {
        public static readonly Guid ID = Guid.Parse("eeb8c1b9-6861-4a36-a37a-22cb2f62af44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Death's Door",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage that would reduce you to 0 Hit Points.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9ae0d40-f859-4357-acd3-138156e24c2c"), Type = TextBlockType.Text, Text = "You continue to fight when others would fall. Just before taking the triggering damage, you gain temporary Hit Points equal to twice your level. If you have Hit Points remaining after gaining these temporary Hit Points, you aren’t knocked unconscious, nor do you suffer the other effects of being reduced to 0 Hit Points. Any temporary Hit Points that remain after applying the damage last for up to 4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c04cbde0-407c-4b7b-afe0-5156097477f8"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c82bf85c-e6ad-4986-bbc5-412ffbeceba6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
