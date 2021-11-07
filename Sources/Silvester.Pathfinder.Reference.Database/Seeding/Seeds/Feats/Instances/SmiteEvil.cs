using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmiteEvil : Template
    {
        public static readonly Guid ID = Guid.Parse("cf971ed3-1704-4191-b522-0438fd369dcc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smite Evil",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a8663c2-318b-43ad-8b4a-c2ad49480095"), Type = TextBlockType.Text, Text = "Your blade ally becomes an even more powerful tool against evildoers. Select one foe you can see. Until the start of your next turn, your (action: Strikes | Strike) with the weapon your blade ally inhabits against that foe deal an extra 4 good damage, increasing to 6 if you have master proficiency with this weapon." };
            yield return new TextBlock { Id = Guid.Parse("9722748c-c9a4-418a-b9ac-307c78269212"), Type = TextBlockType.Text, Text = "If the foe attacks one of your allies, the duration extends to the end of that foe’s next turn. If the foe continues to attack your allies each turn, the duration continues to extend." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("e70dce89-899f-4b4e-a993-023029049eb5"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("cdc92871-5a8f-48c3-9662-6baa670a20bd"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef3f2d51-fca5-41a2-8c59-c74ec65662f3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
